import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { KeyboardResponse } from './models/keyboardResponse.interface';
import { KeyboardRequest } from './models/keyboardRequest.interface';

@Injectable({
  providedIn: 'root',
})
export class KeyboardService {
  constructor(private httpClient: HttpClient) {}

  public get(): Observable<KeyboardResponse[]> {
    return this.httpClient.get<KeyboardResponse[]>(
      'https://localhost:7115/api/Keyboards'
    );
  }

  public post(body: KeyboardRequest): Observable<void> {
    return this.httpClient.post<void>(
      'https://localhost:7115/api/Keyboards',
      body
    );
  }

  public delete(id: number): Observable<void> {
    return this.httpClient.delete<void>(
      `https://localhost:7115/api/Keyboards/${id}`
    );
  }
}
