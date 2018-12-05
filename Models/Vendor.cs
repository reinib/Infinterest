using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
   public class Vendor : BaseEntity
    {   
        public int VendorId {get; set;}
        public string Name {get; set;}
        public string Contact {get; set;}
        public string Company {get; set;}
        public string Bio {get; set;}
        public int AreaOfhouse {get; set;}
        public int BusinessCategory {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public List<VendorReview> VendorReviews {get; set;}
        public List<BrokerReview> BrokerReviews {get; set;}
        public List<Listing> Listings {get; set;}

        public Vendor()
        {
            VendorReviews = new List<VendorReview>();
            BrokerReviews = new List<BrokerReview>();
            Listings = new List<Listing>();
        }
        

    }   
}