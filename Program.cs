public class program{
    
   static void Main(string[] args) {
        float count = 0;
        float sum = 0;
        float max = int.MinValue;
        float min = int.MaxValue;
        bool end = false;
        while (!end) {
            string user_input = Console.ReadLine();
            if (user_input.ToLower() == "end") {
                end = true;
            }
            else if (int.TryParse(user_input, out int number)) {
                count++;
                sum += number;
                max = Math.Max(max, number);
                min = Math.Min(min, number);
            }
            else {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        end = false;
            Console.Write("Enter a mode (FindMax, FindMin, FindMean) or type 'End' to exit: ");
            string mode = Console.ReadLine().ToLower();
            if(false){
            switch (mode) {
                case "findmax":
                    Console.WriteLine($"Max value: {max}");
                    break;
                case "findmin":
                    Console.WriteLine($"Min value: {min}");
                    break;
                case "findmean":
                    if (count > 0) {
                        Console.WriteLine($"Mean value: {(double)sum / count}");
                    }
                    else {
                        Console.WriteLine("No numbers were entered.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid mode.");
                    end = false;
                    break;
            }
            } 
        }
}
