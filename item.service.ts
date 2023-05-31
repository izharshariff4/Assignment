import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Items } from '../Model/Items'

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  url : string = "http://localhost:3000/MenuItems"
  constructor(private http : HttpClient) { }

  public getAllItems() : Observable<Items[]>{
    return this.http.get<Items[]>(this.url) 
  }

  public getItem(id : number) : Observable<Items>{
    let tempUrl = this.url + "/" + id;
    return this.http.get<Items>(tempUrl);
  }

  public addItem(item : Items) : Observable<Items>{
    return this.http.post<Items>(this.url, item);
  }

  public deleteItem(id : number) : Observable<string>{
    let tempUrl = this.url + "/" + id;
    return this.http.delete<string>(tempUrl); 
  }

  public updateItem(item : Items) : Observable<Items>{
    const tempUrl = this.url + "/" + item.id;
    return this.http.put<Items>(tempUrl, item);    
  }
}