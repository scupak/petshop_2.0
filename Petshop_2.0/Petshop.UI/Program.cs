using Petshop.core.ApplicationServices;
using Petshop.core.DomainServices;
using Petshop.infraStructure.Data;

namespace Petshop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPetRepository petRepository = new PetRepository();
            petRepository.InitData();
            IPetService petService = new PetService(petRepository);

            IOwnerRepository ownerRepository = new OwnerRepository();
            ownerRepository.InitData();
            IOwnerService ownerService = new OwnerService(ownerRepository);


            Printer print = new Printer(petService,ownerService);
            print.PrintMenu();
        }

    }
}
