package scannerpractices;
import java.util.Scanner;
public class CelsiusToKelvin {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Celsius: ");
		float cel = sc.nextInt();
		
		float kelv = cel + 273.15f;
		System.out.print("Converted Kelvin is: "+kelv);
		

	}

}
