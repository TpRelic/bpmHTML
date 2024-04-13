using System;
using System.Media;
using System.Threading;

class HeartbeatSimulator {
    static void Main() {
        // Constants for the simulation
        double HR = 100;    // Normal resting heart rate in BPM
        double H0 = 200;    // Initial heart rate in BPM
        double k = 0.003;   // Constant for heart rate decay
        double t = 0;       // Initial time
        
        double currentHeartRate;
        int delayMilliseconds;
        
        while (true) {
            currentHeartRate = HR + (H0 - HR) * Math.Exp(-k * t);
            delayMilliseconds = (int)(60000.0 / currentHeartRate);  // Calculate delay in milliseconds

            Console.WriteLine($"Beat!\tTime: {t:F2} s, Heart Rate: {currentHeartRate:F2} BPM\n\n\n");
            
            PlayHeartbeatSound(@"path_to_heartbeat.wav");
            
            // Sleep for the calculated delay
            Thread.Sleep(delayMilliseconds);

            t += delayMilliseconds / 1000.0; // Update time
        }
    }
    
    static void PlayHeartbeatSound(string audioFilePath) {
        
    }
}
