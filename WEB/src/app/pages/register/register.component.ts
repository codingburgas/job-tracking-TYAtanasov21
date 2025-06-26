import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss',
  standalone: true,
  imports: [ReactiveFormsModule]
})
export class RegisterComponent {
  registerForm: FormGroup;
  message: string = '';
  error: string = '';

  constructor(private fb: FormBuilder, private auth: AuthService) {
    this.registerForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required],
      role: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.registerForm.invalid) return;
    this.auth.register(this.registerForm.value).subscribe({
      next: res => {
        this.message = res.message;
        this.error = '';
        this.registerForm.reset();
      },
      error: err => {
        this.error = err.error?.message || 'Registration failed.';
        this.message = '';
      }
    });
  }
}
