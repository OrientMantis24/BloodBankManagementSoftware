using System.Collections.Generic;

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
                    if (Name != "" && Town != "" && PhoneNumber != "___-___-___")
                    {
                        if (Donator.Name == Name && Donator.Town == Town && Donator.PhoneNumber == PhoneNumber)
                            DonatorList.Add(Donator);
                    }
                    else if (Name != "" && Town != "" && PhoneNumber == "___-___-___")
                    {
                        if (Donator.Name == Name && Donator.Town == Town)
                            DonatorList.Add(Donator);
                    }
                    else if (Name != "" && Town == "" && PhoneNumber != "___-___-___")
                    {
                        if (Donator.Name == Name && Donator.PhoneNumber == PhoneNumber)
                            DonatorList.Add(Donator);
                    }
                    else if (Name == "" && Town != "" && PhoneNumber != "___-___-___")
                    {
                        if (Donator.PhoneNumber == PhoneNumber && Donator.Town == Town)
                            DonatorList.Add(Donator);
                    }
                    else if (Name == "" && Town == "" && PhoneNumber != "___-___-___")
                    {
                        if (Donator.PhoneNumber == PhoneNumber)
                            DonatorList.Add(Donator);
                    }
                    else if (Name != "" && Town == "" && PhoneNumber == "___-___-___")
                    {
                        if (Donator.Name == Name)
                            DonatorList.Add(Donator);
                    }
                    else if (Name == "" && Town != "" && PhoneNumber == "___-___-___")
                    {
                        if (Donator.Town == Town)
                            DonatorList.Add(Donator);
                    }


                }
            }
            return DonatorList;
        }
        public static List<Donator> GetDonator(string BloodGroup, string RhFactor)
        {
            List<Donator> DonatorList = new List<Donator>();

            using (var context = new DonatorContext())
            {
                foreach (var Donator in context.Donators)
                {
                    if (Donator.BloodGroup == BloodGroup && Donator.RhFactor == RhFactor)
                        DonatorList.Add(Donator);
                }
            }

            return DonatorList;
        }
    }
}
