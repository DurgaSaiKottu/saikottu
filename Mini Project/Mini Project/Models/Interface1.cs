using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationApp.Interface
{
    public interface ITrainRepository
    {
        void AddTrain();
        void ModifyTrain();
        void DeleteTrain();
        void BookTicket();
        void ShowAllTrains();
        void CancelTicket();
        void ShowBookings();

    }
}
