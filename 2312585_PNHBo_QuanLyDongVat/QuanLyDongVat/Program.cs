using QuanLyDongVat;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Animal animal = new Animal();
//animal.Speak();
CatFish catFish = new CatFish();

//Animal catfish1 = new CatFish();
//catfish1.Speak();
//((CatFish)catfish1).Eat();

//Animal rabbit2 = new Rabbit();
//rabbit2.Speak();
//((Rabbit)rabbit2).Eat();

//Animal catfish2 = new Animal();
//catfish2.Speak();

Animal animal1 = new Animal();
catFish =(CatFish)animal1;
animal1.Speak();



