import { Pipe, PipeTransform } from '@angular/core';
import { Items } from '../Model/Items';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: Items[], name: string): Items[] {
    if(name == "")
      return value
      else{
        return value.filter((e => e.ItemName.toLowerCase().includes(name.toLowerCase())));
      } 
  }

}