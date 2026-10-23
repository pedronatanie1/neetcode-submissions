public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int slowestSpeed = 1, fastestSpeed = piles.Max();

        while (slowestSpeed < fastestSpeed)
        {
            int speedToTry = slowestSpeed + (fastestSpeed - slowestSpeed) / 2;
            long hoursNeeded = 0;

            foreach (var bananasInPile in piles)
            {
                hoursNeeded += (long)Math.Ceiling((double)bananasInPile / speedToTry);
            }

            if (hoursNeeded > h)
            {
                slowestSpeed = speedToTry + 1;
            }
            else 
            {
                fastestSpeed = speedToTry;
            }
        }
        return slowestSpeed;
    }
}
