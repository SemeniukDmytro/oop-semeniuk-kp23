using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PetOwner
    {
        public string Name { get => _name; set => _name = value; }
        public string PetQR { get => _petQR; }

        private string _name;
        private string _petQR;
        private int phoneNumber;
        private string address;

        public PetOwner(string name, string petQR, int phoneNumber, string address)
        {
            _name = name;
            _petQR = petQR;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public void OnPetGetLost(object source, PetGetLostEventArgs e)
        {
            if (e.QR == _petQR)
            {
                Console.WriteLine($"Oh, thank God you found my pet, please tell me your location or bring him to my home {address}");
            }
        }
    }
}
