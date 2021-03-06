﻿using System;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class AdjustBrightnessDICOM
    {
        public static void Run()
        {
            // ExStart:AdjustBrightnessDICOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            // Load a DICOM image in an instance of DicomImage
            using (DicomImage image = new DicomImage(dataDir + "image.dcm"))
            {
                // Adjust the brightness
                image.AdjustBrightness(50);

                // Create an instance of BmpOptions for the resultant image and Save the resultant image
                image.Save(dataDir + "AdjustBrightnessDICOM_out.bmp", new BmpOptions());
            }
            // ExEnd:AdjustBrightnessDICOM
        }
    }
}