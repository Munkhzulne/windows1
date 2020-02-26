using System;
namespace Task2
{
    public class Class2
    {
        public string publicName;
        private int privateAge;
        public Class2()
        {
        }
        public void setPublicName (string ner)
        {
            publicName = ner;
        }
        public void setPrivateAge(int nas)
        {
            privateAge = nas;
        }
        public void printPublicName()
        {
            Console.WriteLine("PublicName: " + publicName);
        }
        public void printPrivateAge()
        {
            Console.WriteLine("PrivateAge: " + privateAge);
        }
        public string getPublicName()
        {
            return publicName;
        }
        public int getPrivateAge()
        {
            return privateAge;
        }
    }
}
