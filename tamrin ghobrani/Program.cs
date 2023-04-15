//amirhosein hoseinpoor tamrin ghobrani
using tamrin_ghobrani.model;
using opreations;
string address = @"E:\orders.csv";
Digikalacontext context = new Digikalacontext(address);
Digikalaopreations op = new Digikalaopreations(context.digikalas);
