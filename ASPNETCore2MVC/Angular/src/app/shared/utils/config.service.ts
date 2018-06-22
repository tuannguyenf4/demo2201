import { Injectable } from '@angular/core';

@Injectable()
export class ConfigService {
  _apiUrl: string;
  constructor() {
    this._apiUrl = 'http://localhost:49221';
  }
  getApiUrl() {
    return this._apiUrl;
  }
}
