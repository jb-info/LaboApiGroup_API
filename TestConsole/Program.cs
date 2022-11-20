// See https://aka.ms/new-console-template for more information
using LaboApiGroup_Repo.Entities;
using LaboApiGroup_Repo.Repositories;
using LaboApiGroup_Repo.Utils;
using System.Reflection;

//Role u = new();

//foreach (var item in u.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
//{
//    string[] v = item.Name.Split('>');
//    //Console.WriteLine(v[0].Substring(1));


//    Console.WriteLine(item.DeclaringType.Name);
//}

RoleRepo r = new();

foreach (var item in r.GetAll())
{
    Console.WriteLine(item.Name);
}

