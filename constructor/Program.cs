//amespace naveen{


class constr{
    int id;
    string name;
    public static void Main(String[] args){
        
     constr n2=new constr();
          constr n=new constr(20 ,"naveen");

    }
    constr(){
        Console.WriteLine("Hey im default constuctor");
    }
    constr(int id, string name){
        this.id = id;
        this.name = name;
        Console.WriteLine("student number :" + id);
                Console.WriteLine("student name :" + name);


    }


}
