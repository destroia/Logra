import { Component, OnInit } from '@angular/core';
import { HubConnectionBuilder, HubConnection } from '@aspnet/signalr';
import { Builder } from 'protractor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  public hubConnection: HubConnection;
  ngOnInit(): void {
    console.log("Comienzo");
    let builder = new HubConnectionBuilder();

    this.hubConnection = builder.withUrl("https://localhost:44313/Notificacion").build();

    this.hubConnection.on("NotificacionPatrol", data => { console.log(data) });

    this.hubConnection.start()
      .then(() => console.log("Conection...."));
  }
  
    title = 'LograWeb';
}

