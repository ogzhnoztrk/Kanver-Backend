using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Conctrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EfComplaintDal complaintDal = new EfComplaintDal();
            ComplaintMan complaintMan = new ComplaintMan(complaintDal);


            Complaint complaint = new Complaint();
            complaint.ComplaintContent = "asdasdas";
            
            complaintMan.Add(complaint);

        }
    }
}