using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                new Manager();
                new Worker();
                new Robot();
            };

            foreach (var worker in workers)
            {
                worker.work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
        };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }

    interface IWorker
    {
        void Work();
  
    }
    
    interface IEat
    {
        void Eat();
    }

    interface ISalaray
    {
        void GetSalaray();
    }



    class Manager : IWorker, IEat, ISalaray
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalaray()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalaray
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalaray()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
