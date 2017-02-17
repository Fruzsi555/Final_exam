// exam_test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "rowChecker.h"

int main(int argc, const char * argv[]) {
  std::vector<std::vector<int> > my_list = { { 1, 2, 3 },{ 4, 5, 6 },{ 8, 2, 4, 6 } };
  sum_row_numbers(my_list);
  std::vector<int> rows = sum_row_numbers(my_list);

  for (unsigned int i = 0; i < rows.size(); ++i) {
	std::cout << rows[i] << std::endl;
  }

  return 0;
}

