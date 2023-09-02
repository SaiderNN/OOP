using DeviceControl;
using MeasuringDevice;
using System;

internal class MeasureLengthDevice : IMeasuringDevice
{
    public int[] GetRawData()
    {
        return dataCaptured;
    }

    public decimal ImperialValue()
    {
        if (unitsToUse == Units.Imperial)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 0.03937m;
    }

    public decimal MetricValue()
    {
        if (unitsToUse == Units.Metric)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 25.4m;
    }

    public void StartCollecting()
    {
        controller = DeviceController.StartDevice(measurementType);
        GetMeasurements();

    }

    public void StopCollecting()
    {
        if (controller != null)
        {
            controller.StopDevice();
            controller = null;
        }
    }

    private void GetMeasurements()
    {
        dataCaptured = new int[10];
        System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
        {
            int x = 0;
            Random timer = new Random();
            while (controller != null)
            {
                System.Threading.Thread.Sleep(timer.Next(1000, 5000));
                dataCaptured[x] = controller != null ?
                    controller.TakeMeasurement() : dataCaptured[x];
                mostRecentMeasure = dataCaptured[x];
                x++;
                if (x == 10)
                {
                    x = 0;
                }
            }
        });
    }

    public MeasureLengthDevice(Units units)
    {
        unitsToUse = units;
    }

    private Units unitsToUse;
    private int[] dataCaptured;
    private int mostRecentMeasure;
    private DeviceController controller;
    private const DeviceType measurementType = DeviceType.LENGTH;

}

public class MeasureLengthDevice2 : MeasureDataDevice
{

    public override decimal ImperialValue()
    {
        if (unitsToUse == Units.Imperial)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 0.03937m;
    }

    public override decimal MetricValue()
    {
        if (unitsToUse == Units.Metric)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 25.4m;
    }


    public MeasureLengthDevice2(Units units)
    {
        unitsToUse = units;
        measurementType = DeviceType.LENGTH;
    }

}
