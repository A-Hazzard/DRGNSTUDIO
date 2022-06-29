import java.io.;
import java.util.Scanner;
public class TheatreSales {
     public static void main(String[] args) {
         try{
             File Reader myreader = new FileReader("sales.txt");
             FileWriter mywriter = new FileWriter("revenue.txt");


         
         //Scanner variable
         Scanner input = new Scanner(myreader)

         String firstname, lastname;
         double tkprice, nosold, tksales;

         while(input.hasNext()) {

            firstname = input.next();
            lastname = input.next();
            tkprice = input.nextDouble();
            nosold = input.nextDouble();
            tksales = tkprice * nosold;
            
            //write to output file
            mywriter.write(firstname, "   ", lastname, " ", tksales + "\r\n");



         }

         catch(IOException e) {
             System.out.println("File Error");
        
    }
        
    }
