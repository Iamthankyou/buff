package laptrinhonline;

import java.io.DataInputStream;
import java.io.IOException;

public class LuongNuoc {
	static class Reader{
		final private int SIZE = 1<<16;
		private DataInputStream din;
		private byte[] buffer;
		private int bufferPointer,bytesRead;
		
		public Reader() {
			din = new DataInputStream(System.in);
			buffer = new byte[SIZE];
			bufferPointer = bytesRead = 0;
		}
		
		private byte read() throws IOException{
			if (bufferPointer == bytesRead) {
				fillBuffer();
			}
			
			return buffer[bufferPointer++];
		}
		
		private void fillBuffer() throws IOException{
			bytesRead = din.read(buffer, bufferPointer=0,SIZE);
			
			if (bytesRead == -1) {
				buffer[0] = -1;
			}
		}
		
		public long nextLong() throws IOException{
			long res = 0;
			byte c = read();
			
			while (c<= ' ') {
				c = read();
			}
			
			boolean neg = (c == '-');
			
			if (neg) {
				c = read();
			}
			
			do {
				res = res*10 + c-'0';
			}
			while ((c= read()) >= '0' && c <='9');
			
			if (neg) {
				return -res;
			}
			
			return res;
		}
	}
	
	private long[] arr;
	private int n;
	
	public LuongNuoc(long[] arr, int n) {
		this.arr = arr;
		this.n = n;
	}
	
	public LuongNuoc() throws IOException {
		init();
	}
	
	public void init() throws IOException {
		Reader reader = new Reader();
		n = (int)reader.nextLong();
		arr = new long[n];
		
		for (int i=0; i<n ;i++) {
			arr[i] = reader.nextLong();
		}
		
	}
	
	public long res() {
		long[] L = new long[arr.length];
		long[] R = new long[arr.length];
		long res = 0;
		
		L[0] = arr[0];
		R[n-1] = arr[n-1];
		
		for (int i=1; i<n; i++) {
			L[i] = Math.max(L[i-1],arr[i]);
		}
		
		for (int i=n-2; i>=0; i--) {
			R[i] = Math.max(R[i+1],arr[i]);
		}
		
		for (int i=1; i<n-1; i++) {
			long x = Math.min(L[i-1],R[i+1]);
			res+=arr[i]<x?x-arr[i]:0;
		}
		
		return res;
	}
	
	public static void main(String args[]) throws IOException {
		LuongNuoc luongNuoc = new LuongNuoc();
		System.out.println(luongNuoc.res());
	}
}
