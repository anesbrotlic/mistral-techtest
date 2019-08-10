import { Pipe, PipeTransform } from "@angular/core";

@Pipe({ name: 'whitespace' })
export class WhitespacePipe implements PipeTransform {

    transform(value: string) {
        return value.replace(",", ", ");
    }

}