using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWithXamarin.SignalR {
    public class SignalRXamarinTest {

        HubConnection connection;

        public Task<bool> InitializeAsync() {

            try {
                connection = new HubConnectionBuilder()
                    .WithUrl("https://twentyfoursignalrchatdev.azurewebsites.net/talkhub")
                    .Build();

                connection.Closed += async (error) => {
                    await Task.Delay(new Random().Next(0, 5) * 1000);
                    await connection.StartAsync();
                };
            } catch (Exception ex) {

                throw;
            }

            return Task.FromResult(true);
        }
    }
}
