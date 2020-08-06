import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { PaymentService } from '../home/home.service';
import Homeservice = require("../home/home.service");
import PaymentSelection = Homeservice.PaymentSelection;

describe('PaymentService', () => {

  let service: PaymentService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [PaymentService]
    });
    service = TestBed.get(PaymentService);
    httpMock = TestBed.get(HttpTestingController);
  });
  afterEach(() => {
    httpMock.verify();
  });

  it('Should create service component', () => {
    expect(service).toBeTruthy();
  });

  it('Should process the payment as selected', () => {

    const data: PaymentSelection = {
        type: 'selected payment type processed' };

    service.processPayment('upgrade').subscribe(posts => {
      expect(posts).toEqual(data);
    });

    const request = httpMock.expectOne(
      { method: 'POST', url: service.baseUrl + '/paymentgateway' });

    expect(request.request.method).toBe('POST');
    request.flush(data);

  });

});
