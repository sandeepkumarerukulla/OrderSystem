import { Component } from '@angular/core';
import { PaymentService } from './home.service';

export class PaymentType {
  value: string;
  display: string;
}

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  selectedValue: string;
  selectedType: PaymentType;
  errorMessage: string;

  constructor(
    public readonly paymentService: PaymentService) {

  }

  paymentTypes: PaymentType[] = [
    { value: 'Physical product', display: 'Physical product' },
    { value: 'Book', display: 'Book' },
    { value: 'Membership', display: 'Membership' },
    { value: 'Upgrade', display: 'Upgrade' },
    { value: 'Learning to Ski video', display: 'Learning to Ski video' }
  ];

  onChange(paymentType: any) {

    this.paymentService.processPayment(paymentType).subscribe(res => {
        this.selectedValue = res.type;
      },
      error => {
        console.log(error);
      }

    );
  }
}
