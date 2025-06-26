import { Component, OnInit } from '@angular/core';
import { Job } from '../../models/job.model';
import { JobService } from '../../services/job.service';

@Component({
  selector: 'app-job-list',
  templateUrl: './job-list.component.html',
  styleUrls: ['./job-list.component.scss']
})
export class JobListComponent implements OnInit {
  jobs: Job[] = [];

  constructor(private jobService: JobService) {}

  ngOnInit(): void {
    this.jobService.getAllJobs().subscribe(data => {
      this.jobs = data;
    });
  }
}
