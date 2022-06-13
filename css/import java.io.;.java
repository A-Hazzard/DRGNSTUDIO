import java.io.;
import java.util.Scanner;
public class TheatreSales {
     public static void main(String[] args) {
         try{
             File Reader myreader = new FileReader("Numbers.txt");
             FileWriter mywriter = new FileWriter("stats.txt");

             Scanner input = new Scanner(myreader)
         }
        catch(IOException e){
            System.out.println("File error!") 
        }
    }