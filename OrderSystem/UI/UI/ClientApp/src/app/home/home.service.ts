import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from "rxjs";
import { catchError } from 'rxjs/operators';
import { environment } from '../../environments/environment';

@Injectable()
export class PaymentService {
  public readonly baseUrl = environment.baseUrl;

  constructor(private readonly httpClient: HttpClient) {

  }

  private handleError(errorResponse: HttpErrorResponse) {
    return throwError(errorResponse);
  }



  processPayment(type: string): Observable<PaymentSelection> {
    let param: any = { 'PaymentSelection': type };

    let obj: PaymentSelection = {
      type: type
    };

    return this.httpClient.post<PaymentSelection>(this.baseUrl + '/paymentgateway', obj).pipe(catchError(this.handleError.bind(this)));
  }


}

export class PaymentSelection {
  public type: string;
}
