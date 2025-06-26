import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss',
  standalone: true,
  imports: [ReactiveFormsModule]
})
export class LoginComponent {
  loginForm: FormGroup;
  error: string = '';

  constructor(private fb: FormBuilder, private auth: AuthService) {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.loginForm.invalid) return;
    this.auth.login(this.loginForm.value).subscribe({
      next: res => {
        this.auth.setToken(res.token);
        this.error = '';
        // Optionally redirect or show success
      },
      error: err => {
        this.error = err.error?.message || 'Login failed.';
      }
    });
  }
}
