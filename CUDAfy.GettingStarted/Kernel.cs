using Cudafy;
using Cudafy.Host;
using Cudafy.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUDAfy.GettingStarted
{
    public class Kernel
    {
        public static void Execute()
        {
            CudafyModule km = CudafyTranslator.Cudafy();
            GPGPU gpu = CudafyHost.GetDevice(CudafyModes.Target, CudafyModes.DeviceId);
            gpu.LoadModule(km);
            gpu.Launch().TheKernel(); // or gpu.Launch(1, 1, "kernel");
            Console.WriteLine("Hello, World!");
        }

        [Cudafy]
        public static void TheKernel()
        {

        }
    }
}
