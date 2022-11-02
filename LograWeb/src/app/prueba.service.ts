import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PruebaService {

  constructor(private http: HttpClient) { }

  getPueba(): Observable<boolean>{
    return this.http.get < boolean>("https://localhost:44313/weatherforecast");
  }
}
