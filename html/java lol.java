// Online Java Compiler
// Use this editor to write, compile and run your Java code online

public class Speed {
    public static void main (String [] args){
        double sec = 2 * 60;
        
        //method call
        speed("truck", 400, sec);
        
        
        
    }//end main
    public static void speed(String type, double distance, double time)
    double sp = distance/time;
    System.out.println("Vehicle:"+type);
    System.out.println("Speed: " + speed);
}
public class AirlineTicket{
    //attributed
    private String destination;
    private double cost;
    private String passengerName;
    //contructor
    public AirlineTicket(String dest, double cs, String passName)_
    destination = dest;
    cost = c;
    passengerName = passName;
}
//getmethods or accessors
public String getPassengerName(){
    return passengerName;
}
public double getCost(){
    return cost;
}
//set method or mutator
public void setCost(double c){
    cost = c;
}
public String toString(){
    return "Passenger name: " + passengerName + "\nDestination: " + destination;
}
public class InternationalTravel {
    public static void main (String[] args){
        //create objects
       public Airlineticket t1 = new AirlineTicket()
    }
}