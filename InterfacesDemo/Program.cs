

using InterfacesDemo;

IWorker[] workers = new IWorker[3]
{
new Manager(),
new Worker(),
new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eat = new IEat[2]
{
    new Worker(),
    new Manager(),
};