package scannerpractices;
import java.util.Scanner;
public class FahrenheitToCelsius {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Convert celsius to fahrenhiet 
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Fahrenheit: ");
		float fahr = sc.nextFloat();
		//int fahr = sc.nextInt();
		float cel = (fahr-32)*5/9;
		System.out.print("Converted Celsius is: "+cel);
		
		

	}

}
