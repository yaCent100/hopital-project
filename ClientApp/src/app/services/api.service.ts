import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = 'https://localhost:5001/api/test/message';

  constructor(private http: HttpClient) { }

  // Appel GET vers l'API
  getMessage(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
