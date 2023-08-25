using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zdataacess;
using Zmodel;

namespace Any1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer1 customer1 = new Customer1();
            customer1.Custome();
            customer1.Custome1();
            customer1.Custome2();
            
            Restaurant2 restaurant2 = new Restaurant2();
            restaurant2.Restaurant();
            restaurant2.Restaurant1();
            restaurant2.Restaurant3();
            Orderr2 orderr2 = new Orderr2();
            orderr2.Orderr();
            orderr2.Orderr1();
            orderr2.Orderr3();
            Payment2 payment2 = new Payment2();
            payment2.Payment();
            payment2.Payment1();
            payment2.Payment3();
            Restrofood2 restrofood2 = new Restrofood2();
            restrofood2 .Restrofood();
            restrofood2.Restrofood1();
            restrofood2.Restrofood3();



           Customer customer= new Customer();
            customer.Cus();
            customer.Cus1();
            customer.Cus2();
            Restaurant restaurant = new Restaurant();
            restaurant.Three();
            restaurant.Three1();
            restaurant.Three2();
            Orderr orderr=new Orderr();
            orderr.Any();
            orderr.Any2();
            orderr.Any3();
            Payment payment = new Payment();
            payment.Two();
            payment.Two1();
            payment.Two2();
            Restrofood restrofood = new Restrofood();
            restrofood.four();
            restrofood.four1();
            restrofood.four2();
        }
    }
}
