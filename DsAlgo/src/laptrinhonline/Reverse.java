package laptrinhonline;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Reverse {
	public static void main(String args[]) {
		String s = "Đừng cố viết tại mình tự viết chương trình để nó nhắn ngược lại nên mới nhanh vậy đấy";
		
		String[] arr = s.split(" ");
		
		
//		for (int i=0; i<arr.length/2; i++) {
//			String tmp = arr[i];
//			arr[i] = arr[i+1];
//			arr[i+1] = tmp;
//		}
//		
		Collections.reverse(Arrays.asList(arr));
		
//		for (int i=s.length()-1; i>=0; i--) {
//			System.out.print(s.charAt(i));
//		}
		
		for (String i:arr)
			System.out.print(i+" ");
	}
}
