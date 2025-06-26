import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Job } from '../models/job.model';

@Injectable({
  providedIn: 'root'
})
export class JobService {
  private apiUrl = 'https://localhost:5001/api/jobs';

  constructor(private http: HttpClient) {}

  getAllJobs(): Observable<Job[]> {
    return this.http.get<Job[]>(this.apiUrl);
  }
}
