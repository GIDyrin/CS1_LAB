namespace CS1_LAB.Models
{
    public class PersonalComputer
    {
        // Свойства ПК
        public string Processor { get; set; }
        public short RamSize { get; set; } // в ГБ
        public int StorageSize { get; set; } // в ГБ
        public short UsbPortCounts { get; set; }

        public PersonalComputer(string processor, short ramSize, int storageSize, short usbCount)
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
    }
    
}
