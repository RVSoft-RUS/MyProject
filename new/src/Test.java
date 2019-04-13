import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.nio.charset.Charset;

public class Test {
	private int num;

	public static void main(String[] args) {
		Charset koi8 = Charset.forName("KOI8-R");
		Charset win = Charset.forName("Windows-1251");

		byte[] oldArray = new byte[100]; //Имеющийся массив
		String buf = new String(oldArray, koi8);
	}
}
