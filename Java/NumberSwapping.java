package scannerpractices;
import java.util.Scanner;
public class NumberSwapping {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter number A: ");
		int a = sc.nextInt();
		System.out.print("Enter number B: ");
		int b = sc.nextInt();
		
		a = a + b;
        b = a - b;
        a = a - b;
		
		System.out.println("After swapping A: "+a);
		System.out.print("After swapping B: "+ b);
				

	}

}
