namespace CS1_LAB.Models
{

    public abstract class WorkMachine
    {
        public string Processor { get; set; }
        public short RamSize { get; set; } // в ГБ
        public int StorageSize { get; set; } // в ГБ
        public short UsbPortCounts { get; set; }

        public WorkMachine(string processor, short ramSize, int storageSize, short usbCount)
        {
            Processor = processor;
            RamSize = ramSize;
            StorageSize = storageSize;
            UsbPortCounts = usbCount;
        }

        public void PowerOn()
        {
            Console.WriteLine("Компьютер включён.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Компьютер выключен.");
        }

        public void Reboot()
        {
            Console.WriteLine("Перезагрузка компьютера.");
        }

        // Абстрактный метод, который должен быть реализован в производных классах
        public abstract void Perform();
    }

    public class OfficeMachine : WorkMachine
    {
        public bool HasOfficePackage { get; set; }

        public OfficeMachine(string processor, short ramSize, int storageSize, short usbCount, bool hasOfficePackage)
            : base(processor, ramSize, storageSize, usbCount)
        {
            HasOfficePackage = hasOfficePackage;
        }

        public override void Perform()
        {
            Console.WriteLine("Использование офисных приложений.");
        }

        public void UseOfficeApp()
        {
            Console.WriteLine("Запуск офисного приложения.");
        }
    }

    public class ServerMachine : WorkMachine
    {
        public int CoresCount { get; set; }
        public bool HasRedundantPower { get; set; }

        public ServerMachine(string processor, short ramSize, int storageSize, short usbCount, int coresCount, bool hasRedundantPower)
            : base(processor, ramSize, storageSize, usbCount)
        {
            CoresCount = coresCount;
            HasRedundantPower = hasRedundantPower;
        }

        public override void Perform()
        {
            Console.WriteLine("Запуск веб-сервера.");
        }

        public void HostWebsite()
        {
            Console.WriteLine("Запуск веб-сервера.");
        }
    }

    public class LaptopMachine : WorkMachine
    {
        public float ScreenSize { get; set; }
        public bool HasTouchscreen { get; set; }

        public LaptopMachine(string processor, short ramSize, int storageSize, short usbCount, float screenSize, bool hasTouchscreen)
            : base(processor, ramSize, storageSize, usbCount)
        {
            ScreenSize = screenSize;
            HasTouchscreen = hasTouchscreen;
        }

        public override void Perform()
        {
            Console.WriteLine("Использование ноутбука.");
        }

        public void UseLaptop()
        {
            Console.WriteLine("Использование ноутбука.");
        }
    }

    public class GamingMachine : WorkMachine
    {
        public string GraphicsCard { get; set; }
        public bool HasRgbLighting { get; set; }

        public GamingMachine(string processor, short ramSize, int storageSize, short usbCount, string graphicsCard, bool hasRgbLighting)
            : base(processor, ramSize, storageSize, usbCount)
        {
            GraphicsCard = graphicsCard;
            HasRgbLighting = hasRgbLighting;
        }

        public override void Perform()
        {
            Console.WriteLine("Запуск игры.");
        }

        public void PlayGame()
        {
            Console.WriteLine("Запуск игры.");
        }
    }
}
