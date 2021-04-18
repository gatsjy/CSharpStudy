using System;
using System.Diagnostics;

// 접근한정자
// 접근한정자로 수식하지 않은 클래스의 멤버는 무조건 private로 접근 수준이 자동으로 지정된다.
// 이말인 즉슨, 클래스 내의 멤버는 일단 감추고 보고, 그 후에 공개할지를 결정하는 것이 순서라는 뜻 입니다.
namespace AccessModifier
{
    class WaterHeater
    {
        // protected는 클래스 외부에서는 접근할 수 없지만, 파생클래스에서는 접근이 가능합니다.
        // 파생클래스란 기반클래스에서 상속으로 인해 코드를 재활용 한 클래스
        protected int temperature;
        
        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        // 같은 어셈블리에 있는 코드에서만 protected로 접근할 수 있습니다. 다른 어셈블리에 있는 코드에서는
        // private 와 같은 수준의 접근성을 가집니다.
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
