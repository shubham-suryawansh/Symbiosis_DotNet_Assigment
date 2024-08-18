import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';


@Component({
  selector: 'app-digit-validation',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './digit-validation.component.html',
  styleUrl: './digit-validation.component.css'
})
export class DigitValidationComponent {
  numberForm: FormGroup;
  formattedNumber: string | null = null;

  constructor(private fb: FormBuilder) {
    this.numberForm = this.fb.group({
      numberInput: ['', [Validators.required, Validators.pattern(/^\d{12}$/)]]
    });
  }

  onSubmit() {
    if (this.numberForm.valid) {
      this.formattedNumber = this.numberForm.value.numberInput;
    }
  }
}