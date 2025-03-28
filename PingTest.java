import java.io.*;

public class PingTest {
    public static void main(String[] args) throws IOException {
        String target = "8.8.8.8";
        Process process = Runtime.getRuntime().exec("ping -c 4 " + target);

        BufferedReader reader = new BufferedReader(new InputStreamReader(process.getInputStream()));
        String line;
        while ((line = reader.readLine()) != null) {
            System.out.println(line);
        }
    }
}
