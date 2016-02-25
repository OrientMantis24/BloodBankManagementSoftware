using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSoftware
{
    class DonatorsDatabase
    {
        public static List<Donator> GetDonator(string Name, string Town, string PhoneNumber)
        {
            List<Donator> DonatorList = new List<Donator>();

            using (var context = new DonatorContext())
            {
                foreach (var Donator in context.Donators)
                {
                    if(Name != null && Town != null && PhoneNumber != null)
                    {
                        if (Donator.Name == Name && Donator.Town == Town && Donator.PhoneNumber == PhoneNumber)
                            DonatorList.Add(Donator);
                    }
                }
            }
            return DonatorList;
        }
    }
}
