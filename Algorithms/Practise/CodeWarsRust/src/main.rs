fn main() {
    println!("{}", count_sheep(&[false,true,true]));
}

fn square_sum(vec: Vec<i32>) -> i32 {
    let mut b: i32 = 0;

    // let res: i32 = vec.iter().map(|x| x.pow(2)).sum();

    for i in vec {
        b += i32::pow(i, 2);
    }

    return b;
}

fn summation(n: i32) -> i32 {
    return (1..n+1).sum();
}

fn even_or_odd(i: i32) -> &'static str {
    let res = [i as usize % 2];
    println!("{}", res[0]);
    if i % 2 == 0 {
        "Even"
    } else {
        "Odd"
    }
}

fn count_sheep(sheep: &[bool]) -> u8 {
    // sheep.iter().filter(|&&x|x).count() as u8; // alternative
    let mut result = 0;

    for element in sheep {
       if element == &true {
        result +=1;
       }
    }

    return result;
}

#[test]
fn returns_correct_sheep_count() {
  assert_eq!(count_sheep(&[false]), 0);
}
#[test]
fn returns_correct_sheep_count2() {
  assert_eq!(count_sheep(&[true]), 1);
  assert_eq!(count_sheep(&[true, false]), 1);
}
#[test]
fn returns_correct_sheep_count3() {
  assert_eq!(count_sheep(&[true, false]), 1);
}