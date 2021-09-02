using System;
using System.IO;

namespace PrintPreviewInCSharp
{
    class Program
    {
        // the xps writer wants to close the memory stream, we don't want that to happen.
        class MyMemoryStream : MemoryStream
        {
            protected override void Dispose(bool disposing)
            {
                //base.Dispose(disposing);
            }
        }


        internal static void DoPreview(FlowDocument fd, Window owner, string title)
        {
            PrintDialog pd = new PrintDialog();
            // Create a copy because we're going to resize it to match the printer settings
            String copyString = XamlWriter.Save(fd);
            FlowDocument copy = XamlReader.Parse(copyString) as FlowDocument;

            copy.DataContext = fd.DataContext;
            IDocumentPaginatorSource fdd = copy;
            copy.PageWidth = pd.PrintableAreaWidth;
            copy.PageHeight = pd.PrintableAreaHeight;
            copy.ColumnWidth = pd.PrintableAreaWidth;
            copy.PagePadding = new Thickness(30.0, 50.0, 20.0, 30.0);
            copy.IsOptimalParagraphEnabled = true;
            copy.IsHyphenationEnabled = true;

            IDocumentPaginatorSource fdd = copy;
            DoPreview(copy, owner, title);
        }


        internal static void DoPreview(DocumentPaginator fd, Window owner, string title)
        {
            //FlowDocumentScrollViewer visual = (FlowDocumentScrollViewer)(_parent.FindName("fdsv1"));
            var ms = new MyMemoryStream();
            using (var pkg = System.IO.Packaging.Package.Open(ms, FileMode.Create))
            {
                using (XpsDocument doc = new XpsDocument(pkg))
                {
                    XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);
                    writer.Write(fd);
                }
            }
            //ms.ToArray()
            ms.Position = 0;
            var pkg2 = System.IO.Packaging.Package.Open(ms);
            // Read the XPS document into a dynamically generated
            // preview Window 
            var url = new Uri("memorystream://printstream");
            PackageStore.AddPackage(url, pkg2);
            try
            {
                using (XpsDocument doc = new XpsDocument(pkg2, CompressionOption.SuperFast, url.AbsoluteUri))
                {
                    FixedDocumentSequence fds = doc.GetFixedDocumentSequence();
                    string s = _previewWindowXaml;
                    s = s.Replace("@@TITLE", title.Replace("'", "&apos;"));
                    using (var reader = new System.Xml.XmlTextReader(new StringReader(s)))
                    {
                        Window preview = System.Windows.Markup.XamlReader.Load(reader) as Window;
                        DocumentViewer dv1 = LogicalTreeHelper.FindLogicalNode(preview, "dv1") as DocumentViewer;
                        dv1.Document = fds as IDocumentPaginatorSource;
                        preview.Owner = owner;
                        preview.ShowDialog();
                    }
                }
            }
            finally
            {
                PackageStore.RemovePackage(url);
            }
        }

        static void Main(string[] args)
        {
            private static string _previewWindowXaml =
                                                    @"<Window
                                                        xmlns                 ='http://schemas.microsoft.com/netfx/2007/xaml/presentation'
                                                        xmlns:x               ='http://schemas.microsoft.com/winfx/2006/xaml'
                                                        Title                 ='Print Preview - @@TITLE'
                                                        Height                ='600'
                                                        Width                 ='800'
                                                        WindowStartupLocation ='CenterOwner'>
                                                        <DocumentViewer Name='dv1'/>
                                                     </Window>";


    }
}
