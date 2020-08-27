using System;
using System.Collections.Generic;
using System.Text;
using Petshop.core.DomainServices;
using Petshop.Core.Entity;

namespace Petshop.infraStructure.Data 
{
   public class OwnerRepository : IOwnerRepository
    {
        public int Id;
        public List<Owner> Owners;


        public OwnerRepository()
        {
            Id = 0;
            Owners = new List<Owner>();


        }
        public Owner AddOwner(Owner owner)
        {
            Id++;
            owner.Id = Id;
            Owners.Add(owner);
            return owner;
        }

        public Owner EditOwner(Owner owner, int index)
        {
            Owners[index] = owner;
            return Owners[index];
        }

        public List<Owner> GetOwners()
        {
            return Owners;
        }

        public void InitData()
        {
            AddOwner(new Owner("greg", "davidson", "999manstreet", "29999", "mike@email.com"));
            AddOwner(new Owner("alex", "davidson", "999manstreet", "29999", "mike@email.com"));
            AddOwner(new Owner("mike", "davidson", "999manstreet", "29999", "mike@email.com"));
        }
    }
}
