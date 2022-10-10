import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  SERVER_URL='http://localhost:5000/v1/';

  constructor(private https:HttpClient) { }

  public getContratos(){
    return this.https.get(`${this.SERVER_URL}contratos`)
  }
}
