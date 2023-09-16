using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class HomePet : IDisposable, IEquatable<HomePet>
    {
        public string name;
        protected bool _alive;
        private string _qrCodeNumber;
        protected int _age;
        private int ownerPhoneNumber;
        public bool Alive 
        {
            get => _alive;
            set 
            {
                if (_alive == false && value == true) 
                    throw new InvalidOperationException();
                else if (_alive == true && value == false) Dispose();
                _alive = value;
            }
        }

        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if ( 0 <= value && value <= 20) _age = value;
            }
        }
        public string QrCodeNumber { get => _qrCodeNumber; }
        public int OwnerPhoneNumber { get => PhoneNumberPresented(); }

        
        public event EventHandler<PetGetLostEventArgs> PetGetLost;

        public HomePet(string name, string qrCodeNumber, int age, int ownerPhoneNumber)
        {
            this.name = name;
            this._qrCodeNumber = qrCodeNumber;
            this._age = age;
            this.ownerPhoneNumber = ownerPhoneNumber;
            DataBaseManager.AddToDb(_qrCodeNumber, this.ownerPhoneNumber);
        }
        public HomePet()
        {
            this.name = "Unknown";
        }

        public bool Equals(HomePet? other)
        {
            if (other == null) return false;
            return (this._qrCodeNumber.Equals(other.QrCodeNumber));
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            HomePet objAsHomePet = obj as HomePet;
            if (objAsHomePet == null) return false;
            else return Equals(objAsHomePet);
        }
        public override int GetHashCode()
        {
            return int.Parse(_qrCodeNumber);
        }
        private int PhoneNumberPresented()
        {
            if (DataBaseManager.IsPresentedInDB(_qrCodeNumber))
            {
                return ownerPhoneNumber;
            }
            return 0;
        }

        public string GetInfoAboutPet(string qrNumber)
        {
            if (DataBaseManager.IsPresentedInDB(qrNumber))
            {
                return $"Hello, my name is {name}, I'm {_age}. Play with me";
            }
            return "Sorry there isn't any information about this pet";
        }
        public virtual string GetAlias(string name, int age)
        {
            if (name == "Unknown")
            {
                return "Hm, I don't how to call you";
            }
            if (age < 10)
            {
                return $"young {name}";
            }
            return $"quite old {name}";
        }

        public void Dispose()
        {
            Die(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Die(bool disposing)
        {
            if (!_alive)
            {
                return;
            }
            if (disposing)
            {
                DataBaseManager.RemoveFromDb(_qrCodeNumber);
                Alive = false;
            }
            _alive = false;
        }

        protected virtual void OnPetGetLost()
        {
            if(PetGetLost != null)
            {
                PetGetLost(this, new PetGetLostEventArgs() { QR = QrCodeNumber});
            }
        }
        public void CallOwner()
        {
            if (_qrCodeNumber != null && _qrCodeNumber.Length == 7)
            {
                Console.Clear();
                Console.WriteLine($"Please call my owner on this number {ownerPhoneNumber}");
                Console.WriteLine("Calling...");
                Thread.Sleep(3000);
                OnPetGetLost();
            }
            else if (_qrCodeNumber == null)
            {
                throw new CallFailedException(new Args() { code = 404, reason = "homelessPet", status = "Not found" });
            }
            else
            {
                throw new CallFailedException(new Args() { code = 001, reason = "invalidQR", status = "There isn't such QR code" });
            }
            
        }
        ~HomePet()
        {
            Die(false);
            Console.WriteLine("Destructor is called!");
        }
    }
}
