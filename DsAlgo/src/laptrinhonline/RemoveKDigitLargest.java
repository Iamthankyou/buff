package laptrinhonline;

import java.util.Scanner;

public class RemoveKDigitLargest {
	public static void main(String asgs[]) {
		String s;
		Scanner sc = new Scanner(System.in);
		s = sc.next();
		int t = sc.nextInt();

		for (int i=0; i<t; i++) {
			int k = sc.nextInt();
			int index = 0;
			String restore;
			restore = s;
			while (index<s.length()-1 && k>0) {
				if (s.charAt(index)<s.charAt(index+1)) {
					s = s.substring(0,index) + s.substring(index+1);
					index = Math.max(0, index-1);
					k--;
					
				}
				else{
					index++;
				}
			}
			System.out.println(s);
			s = restore;
		}
		
	}
}
