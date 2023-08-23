// expression to evaluate ? <value for returning if it is true> : <value for returning if it is false, or to add more ternary conditions> 

string permission = "Admin";
int level = 40;
Console.WriteLine(
    permission.Contains("Admin")  && level > 55 ? "Welcome, Super Admin user." : 
    (permission.Contains("Admin")  && level < 56 ? "Welcome, Admin user." : 
    permission.Contains("Manager")  && level > 20 ? "Contact an Admin for access." : 
    (permission.Contains("Manager")  && level < 21 ? "You do not have sufficient privileges." : 
    "You do not have sufficient privileges.")));
