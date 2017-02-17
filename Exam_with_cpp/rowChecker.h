#include <iostream>
#include <vector>

std::vector<int> sum_row_numbers(std::vector<std::vector<int> > list) {
	std::vector<int> rows;
	for (unsigned int i = 0; i < list.size(); ++i) {
		int sum = 0;
		for (unsigned int j = 0; j < list[i].size(); ++j) {
			sum += list[i][j];
		}
		rows.push_back(sum);
	}
	return rows;
}