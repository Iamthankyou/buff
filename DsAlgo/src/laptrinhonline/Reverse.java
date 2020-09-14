package laptrinhonline;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Reverse {
	public static void main(String args[]) {
		String s = "Em vừa chạy đâu à ?";
		
		String[] arr = s.split(" ");
		
		
//		for (int i=0; i<arr.length/2; i++) {
//			String tmp = arr[i];
//			arr[i] = arr[i+1];
//			arr[i+1] = tmp;
//		}
//		
//		Collections.reverse(Arrays.asList(arr));
		
		for (int i=s.length()-1; i>=0; i--) {
			System.out.print(s.charAt(i));
		}
		
//		for (String i:arr)
//			System.out.print(i+" ");
	}
}
